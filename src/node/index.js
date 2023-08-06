const totp = require("totp-generator")

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

// Reference: https://github.com/bellstrand/totp-generator
const token = totp("JBSWY3DPEHPK3PXP", {
    digits: 6,
    algorithm: "SHA-1",
    period: 30,
    timestamp: Date.now()
})

console.log(`Current TOTP: ${token}`)