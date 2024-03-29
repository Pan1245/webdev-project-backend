using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace houseofgriffin_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "ep, ea, oa")]

    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpGet("GetPrivatePayment/{reqId}")]
        public async Task<ActionResult<ServiceResponse<List<GetPrivatePaymentDto>>>> GetPaymentByPrivateReqId(int reqId)
        {
            var response = await _paymentService.GetPaymentByPrivateReqId(reqId);
            if (response.Data is null)
                return NotFound(response);
            return Ok(response);
        }

        [HttpPost("Post")]
        public async Task<ActionResult<ServiceResponse<GetPrivatePaymentDto>>> AddPayment(AddPrivatePaymentDto newPayment)
        {
            return Ok(await _paymentService.AddPayment(newPayment));
        }

        [HttpPut("Put")]
        public async Task<ActionResult<ServiceResponse<GetPrivatePaymentDto>>> UpdatePayment(UpdatePrivatePaymentDto updatedPayment)
        {
            var response = await _paymentService.UpdatePayment(updatedPayment);
            if (response.Data is null)
                return NotFound(response);
            return Ok(response);
        }

        [HttpDelete("Delete/{fileId}")]
        public async Task<ActionResult<ServiceResponse<List<GetPrivatePaymentDto>>>> DeletePayment(int fileId)
        {
            var response = await _paymentService.DeletePayment(fileId);
            if (response.Data is null)
                return NotFound(response);
            return Ok(response);
        }


    }

}