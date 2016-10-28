namespace weather.Controllers {

    const apiUrl = "http://api.openweathermap.org/data/2.5/weather?q=phoenix";
    const apiKey = "&appid=a6d940dc413472bdf94225f52ed119d3";

    export class HomeController {
        public search;
        public forecast;

        fetch() {
            if (this.search) {
                console.log(`searching......`);
                this.$http.get(apiUrl + this.search + apiKey)
                    .then((results) => {
                        this.forecast = results.data;
                    });
            }
        }
        constructor(private $http: ng.IHttpService) { }
    }



    export class AboutController {
        public message = 'Hello from the about page!';
    }

}
