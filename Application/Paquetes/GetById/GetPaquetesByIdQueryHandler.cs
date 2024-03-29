using Paquetes.Common;
using Domain.Paquetes;

namespace Application.Paquetes.GetById
{
    internal sealed class GetPaquetesByIdQueryHandler : IRequestHandler<GetPaquetesByIdQuery, ErrorOr<PaqueteResponse>>
    {
        private readonly IPaqueteRepository _paqueteRepository;
        
        public GetPaquetesByIdQueryHandler(IPaqueteRepository paqueteRepository)
        {
            _paqueteRepository = paqueteRepository ?? throw new ArgumentNullException(nameof(paqueteRepository));
        }
        
        public async Task<ErrorOr<PaqueteResponse>> Handle(GetPaquetesByIdQuery query, CancellationToken cancellationToken)
        {
            if (await _paqueteRepository.GetByIdAsync(new PaqueteId(query.Id)) is not Paquete paquete)
            {
                return Error.NotFound("Paquete.NotFound", "The package with the provided Id was not found.");
            }

            return new PaqueteResponse(
                paquete.Id.Value, 
                paquete.Nombre, 
                paquete.Descripcion, 
                paquete.FechaInicio, 
                paquete.FechaFin, 
                paquete.Precio, 
                paquete.Activo);
        }
    }
}
