import {inject} from 'aurelia-framework';
import {HttpClient} from 'aurelia-fetch-client';
import {User} from 'models/user';
import {Pto} from 'models/pto';

import moment from 'moment';
// jspm install npm:moment
@inject(moment)
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
    
    getUser(userId) {
       const user = new User(userId, 'Kevin', 10, 1);
       return Promise.resolve(user);
    }
    
    getUsersPtoForDashboard(userId){
        // retrieve all pto events for the year for this employee
        // cache for next request
        if(this.ptoForUser){
            return Promise.resolve(this.ptoForUser);
        }
        
        this.ptoForUser = { userId: userId, pto: [], totalAvailable: 0 };
       
       // get it from the service...
       this.ptoForUser.totalAvailable = 30;
       // sorted by date desc
       var pto = [ 
           new Pto(1, userId, moment().add(-15, 'days'), moment().add(-15, 'days').add(8, 'hours'), 2),
           new Pto(2, userId, moment().add(-5, 'days'), moment().add(-15, 'days').add(8, 'hours'), 2),
       ];
       this.ptoForUser.pto = pto;
        return Promise.resolve(this.ptoForUser);
    }
}