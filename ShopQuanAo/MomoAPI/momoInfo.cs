using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopQuanAo.MomoAPI
{
    public class momoInfo
    {
        public static readonly string endpoint = "https://test-payment.momo.vn/gw_payment/transactionProcessor";
        public static readonly string partnerCode = "MOMO9MAA20201207";
        public static readonly string accessKey = "aK5CyEIj2hx6ZdNJ";
        public static readonly string serectkey = "WK2pAoCuzpxmgMVqhNq3OMopMeYDRehf";
        public static readonly string orderInfo = "Chinh test momo";
        public static readonly string returnUrl = "http://www.shopquanao.somee.com/confirm-orderPaymentOnline-momo";
        public static readonly string notifyurl = "http://www.shopquanao.somee.com/cancel-order-momo";
    }
}