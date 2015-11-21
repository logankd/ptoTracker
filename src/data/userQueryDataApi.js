import {HttpClient} from 'aurelia-http-client';
import {UserInfo} from 'models/userInfo';
import {Pto} from 'models/pto';

import moment from 'moment';
// jspm install npm:moment
export class UserQueryDataApi {
    //static inject = [HttpClient];
    constructor(http) {
        // debugger;
        // this.http = http;
        // this.baseUrl = 'https://myProject.azure-mobile.net/';
        // this.zumoHeader = 'X-ZUMO-APPLICATION';
        // this.zumoKey = 'zumoKey';
        // this.client = new HttpClient()
        //     .configure(x => {
        //         x.withBaseUrl(this.baseUrl);
        //         x.withHeader(this.zumoHeader, this.zumoKey);
        //     });
    }
    
    getUserInfo(userId) {
       const user = new UserInfo(userId, 'Kevin', 10, 1);
       return new Promise().resolve(user);
    }
    
    getUsersPtoForDashboard(userId){
        // retrieve all pto events for the year for this employee
        // cache for next request
        if(this.ptoForUser){
            return new Promise().resolve(this.ptoForUser);
        }
        
        this.ptoForUser = { userId: userId, pto: [], totalAvailable: 0 };
       
       // get it from the service...
       this.ptoForUser.totalAvailable = 30;
       var pto = [ new Pto(1, userId, new Date(), )]
       this.ptoForUser.pto = 
        return new Promise().resolve(info);
    }
}