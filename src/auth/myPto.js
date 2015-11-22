import {inject} from 'aurelia-framework';
import {UserQueryDataApi} from 'data/userQueryDataApi';
import moment from 'moment';

/**
 * PTO dashboard. 
 **/
 @inject(UserQueryDataApi, moment)
export class MyPto {
	constructor(userQueryDataApi){
		this.userQueryDataApi = userQueryDataApi;
		this.acrualRate = 0;
		this.totalAvailable = 0;
		this.ptoForCurrentMonth = [];
		
		// should init go here?
		this.init(1);
	}
	
	init(userId){
		// get current user's acrual rate and pto for the current month
		return this.userQueryDataApi.getUserInfo(userId).then(userInfo =>{
			this.acrualRate = userInfo.acrualHoursPerMonth;
			
			// figure out continuation
			return this.userQueryDataApi.getUsersPtoForDashboard(userId)
				.then(pto => {
					this.totalAvailable = pto.totalAvailable;
					const allPto = pto.pto.map(p => {
						p.start = moment(p.start).format('lll');
						p.end = moment(p.end).format('lll');
						return p;
					});
					this.ptoForCurrentMonth = allPto;
				});
		});
	}
}