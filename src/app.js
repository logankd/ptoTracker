export class App {
  configureRouter(config, router) { 
    config.title = 'PTO Tracker';
    config.map([
      { route: ['', 'public/login'], name: 'login', moduleId: 'public/login', nav: false, title: 'Login' }
    ]);

    this.router = router;
  }
}