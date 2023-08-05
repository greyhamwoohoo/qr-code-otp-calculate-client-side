# qr-code-otp-calculate-client-side
Calculate the expected client side TOTP at a given time. 

# Potential Scenarios
UI Automation where MFA is required in those environments (usually late-stage environments such as Staging; or Pre-Prod/Prod)

# Setting up & terminology
To calculate the TOTP you will need to collect some information that is normally hidden from you when you scan a QR Code. 

Then enter those parameters in the C# code in this repo. 

## Aegis Authenticator (Recommended)
Scan the QR code for your user using an App such as Aegis Authenticator. Export the Vault/Group from Aegis Authenticator to get something that looks like this:

```
{
    "version": 1,
    "header": {
        "slots": null,
        "params": null
    },
    "db": {
        "version": 2,
        "entries": [
            {
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
        ]
    }
}
```

## 2FA QR Code Generator (Quick 'n' easy)
To decode a QR code and obtain the secret, digits, period and so forth, upload an image of the QR code to [2FA QR Code Generator](https://stefansundin.github.io/2fa-qr/)

NOTE: For security reasons, be sure to run 2fa-qr locally first - it is open source. 

# References
| Reference | Link |
| -- | -- |
| Create ad-hoc QR-Codes for testing; or decode a QR code | https://stefansundin.github.io/2fa-qr/ |
