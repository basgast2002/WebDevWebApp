class gdpr{

    constructor() {
        
        this.bindEvents();

    }

    bindEvents() {
        window.addEventListener("load", this.gdprCookieMessage);
        let buttonAccept = document.querySelector('.gdpr-consent-accept');
        buttonAccept.addEventListener('click', () => {
            
            this.setCookie("gdprCookie", true, 30)
            
            
        });

        let buttonReject = document.querySelector('.gdpr-consent-reject');
        buttonReject.addEventListener('click', () => {
            this.setCookie("gdprCookie", false, 1)
            
        });

    }



    getCookie(cName) {
        const name = cName + "=";
        const cDecoded = decodeURIComponent(document.cookie);
        const cookiesArr = cDecoded.split("; ");
        let value;
        cookiesArr.forEach(val => {
            if (val.indexOf(name) === 0) value = val.substring(name.length);
        })
        return value;
    }

    gdprCookieMessage = () => {
        if (!this.getCookie("gdprCookie"))
            document.querySelector(".gdpr-consent").style.display = "block";
    }


    setCookie = (cName, cValue, expDays) => {
        let date = new Date ();
        date.setTime(date.getTime() + (expDays * 24 * 60 * 60 * 60));
        const expires = "expires=" + date.toUTCString();
        document.cookie = cName + "="  + cValue + ";" + expires + "; path=/";
        document.querySelector(".gdpr-consent").style.display = "none";
        console.log("set");
    }


}
window.addEventListener("load", this.gdprCookieMessage);
const appp = new gdpr()

