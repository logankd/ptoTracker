import {HttpClient} from 'aurelia-http-client';

export class DataApi {
    //static inject = [HttpClient];
    constructor(http) {
        this.http = http;
        this.baseUrl = 'https://myProject.azure-mobile.net/';
        this.zumoHeader = 'X-ZUMO-APPLICATION';
        this.zumoKey = 'zumoKey';
        this.client = new HttpClient()
            .configure(x => {
                x.withBaseUrl(this.baseUrl);
                x.withHeader(this.zumoHeader, this.zumoKey);
            });
    }

    // requests will go here
    testGet() {
        this.client.get('api/logs?application_id=sessionID&__count=20')
            .then(response => {
                alert(response);
            });
    }
}