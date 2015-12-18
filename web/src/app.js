export class App {
  configureRouter(config, router) { 
    config.title = 'PTO Tracker';
    config.map([
      { 
       //TODO: force login if not logged in route: ['', 'public/login'], name: 'login', moduleId: 'public/login', nav: false, title: 'Login' 
         route: ['', 'auth/myPto'], name: 'My PTO', moduleId: 'auth/myPto', nav: true, title: 'My PTO'
      }
    ]);

    this.router = router;
  }
}