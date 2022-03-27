import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { CookieService } from 'ngx-cookie-service';



@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {

  wsUrl:string;
  data:WeatherResponse;
  display:boolean=false;
  iadbunits:string='imperial';

  constructor(private http: HttpClient,
    private cookieService:CookieService,
    @Inject('BASE_URL') baseUrl:string){
    this.wsUrl = baseUrl + 'weatherforecast';
  }

  ngOnInit(){
    this.initialCookieSet();
    this.loadData();
    
  }

  loadData(){
    navigator.geolocation.getCurrentPosition(pos=>{
      let params = "?lat=" + pos.coords.latitude + "&lon=" + pos.coords.longitude + "&unit=" + this.iadbunits;
      this.http.get<WeatherResponse>(this.wsUrl + params).subscribe(result => {
        this.data = result;
        this.display=true;
      }, error => console.error(error));
    })
  }

  initialCookieSet(){
    if(this.cookieService.check('iadbunits'))
      this.iadbunits=this.cookieService.get('iadbunits');
    else
      this.cookieService.set('iadbunits','imperial');
  }

  setCookieVal(val){
    this.cookieService.set('iadbunits',val);
    this.loadData();
    window.location.reload();
  }
}
