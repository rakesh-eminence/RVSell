//import { Injectable } from '@angular/core';
//import { Http, Headers, Response, RequestOptions } from '@angular/http';
//import { Observable } from 'rxjs/Observable';
//import 'rxjs/add/operator/map';
//import { AppConfig } from '../app.configuration';
//import { HttpClient } from '@angular/common/http';
//import { HttpHeaders } from '@angular/common/http';
//import { DataSharingService } from 'app/Services/dataSharingService';
//@Injectable()

//export class HomeService {
//  headers: Headers;
//  options: RequestOptions;
//  appConfig: AppConfig;

//  private customHeaders: HttpHeaders = this._datasharing.setCredentialsHeader();
//  constructor(private _http: Http, private _appConfig: AppConfig, private httpclient: HttpClient, private _datasharing: DataSharingService) {
//    this.headers = new Headers({ 'Content-Type': 'application/json' });
//    this.options = new RequestOptions({ headers: this.headers });
//  }

//  getActivePlansPlans() {
//    debugger;
//    let headers = new Headers();
//    headers.append('Content-Type', 'application/json');
//    let options = new RequestOptions({ headers: headers });
//    //let model = { 'PageNumber': pageNumber, 'PageSize': pageSize, 'SearchKeyword': searchKeyword };
//    return this._http.get(this._appConfig.baseURL + this._appConfig.ApiMethodURL["GetPlansWithoutPagination"])
//      .map((response: any) => {
//        debugger;
//        return response.json();
//      });
//  }
//}


//// WEBPACK FOOTER //
//// ./src/app/Services/home.service.ts
