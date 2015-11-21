import {autoinject} from 'aurelia-framework';
import {UserQueryDataApi} from 'data/userQueryDataApi';
/**
 * PTO dashboard. 
 **/
 @inject(UserQueryDataApi)
export class MyPto {
	constructor(userQueryDataApi){
		debugger;
		this.userQueryDataApi = userQueryDataApi;
		this.acrualRate = 0;
		this.ptoForCurrentMonth = [];
	}
	
	init(userId){
		// get current user's acrual rate and pto for the current month
		return this.userQueryDataApi.getUserInfo(userId).then(userInfo =>{
			this.acrualRate = userInfo.acrualHoursPerMonth;
			
			// figure out continuation
			return this.userQueryDataApi.getUsersPtoForDashboard(userId)
				.then(pto => {
					
				});
		});
	}
}