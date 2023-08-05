using OtpNet;

namespace CalculateClientSideOTP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* TOTP exported from Aegis Authenticator:
             * 
             * {
                "type": "totp",
                "uuid": "95f8c5a2-e87f-472a-99fa-364bc1a21226",
                "name": "TheTestLabel",
                "issuer": "TheTestIssuer",
                "group": "TestTOTP Group",
                "note": "Part of test setup",
                "favorite": false,
                "icon": null,
                "info": {
                    "secret": "JBSWY3DPEHPK3PXP",
                    "algo": "SHA1",
                    "digits": 6,
                    "period": 30
                }
               }
             * 
             */
            var secret = "JBSWY3DPEHPK3PXP";

            var otp = new Totp(secretKey: Base32Encoding.ToBytes(secret),
                step: 30,
                mode: OtpHashMode.Sha1,
                totpSize: 6);

            while (true) 
            { 
                var timestamp= DateTime.UtcNow;

                var computedOtp = otp.ComputeTotp(timestamp);

                Console.WriteLine($"OTP at '{timestamp.ToString("yyyyMMddTHHmmss")}' : {computedOtp}");
            }
        }
    }
}
