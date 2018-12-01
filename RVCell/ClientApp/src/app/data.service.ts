import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Http, Headers, Response } from '@angular/http';
import { RequestOptions } from '@angular/http';
import 'rxjs/add/operator/map';
import { AppconfigurationService } from './appconfiguration.service'
import { PropertyModel } from './models/modalClass'


@Injectable()
export class DataService {
  headers: Headers;
  options: RequestOptions;

  constructor(private http: HttpClient, private appconfigurationService: AppconfigurationService) {
    this.headers = new Headers({ 'Content-Type': 'application/json' });
    this.options = new RequestOptions({ headers: this.headers });
  }


  getBrand(brandId: any) {

    let headers = new Headers();
    headers.append('Content-Type', 'application/json');
    let options = new RequestOptions({ headers: headers });
    return this.http.get(this.appconfigurationService.baseURL + 'PropertyAPI/GetPropertyBrands/' + brandId)
      .map((response: any) => {
          return response;
      });
  }


  getBrandProperty(brandId: any) {

    let headers = new Headers();
    headers.append('Content-Type', 'application/json');
    let options = new RequestOptions({ headers: headers });
    return this.http.get(this.appconfigurationService.baseURL + 'PropertyAPI/GettAllPropertiesByBrands/' + brandId)
      .map((response: any) => {
        return response;
      });
  }

  //GettAllPropertiesWithSearch(propertyModel: PropertyModel) {
    
  //  let headers = new Headers();
  //  headers.append('Content-Type', 'application/json');
  //  let options = new RequestOptions({ headers: headers });
  //  debugger;
  //  var Model = {}
  //  Model = propertyModel;
  //  return this.http.post(this.appconfigurationService.baseURL + 'PropertyAPI/GettAllPropertiesWithSearch/', Model)
  //    .map((response: any) => {
  //      return response;
  //    });
  //}



  GettAllProperties(propertyModel: PropertyModel) {
    
    let headers = new Headers();
    headers.append('Content-Type', 'application/json');
    let options = new RequestOptions({ headers: headers });
    var BrandID = propertyModel.BrandID
    var SkipRows = propertyModel.SkipRows;
    var TakeRows = propertyModel.TakeRows;

    return this.http.get(this.appconfigurationService.baseURL + 'PropertyAPI/GettAllPropertiesWithSearch/' + BrandID + '/' + SkipRows + '/' + TakeRows)
      .map((response: any) => {
        return response;
      });
  }

  getUnitDetailListwView(PropertyID: number) {

    let headers = new Headers();
    headers.append('Content-Type', 'application/json');
    let options = new RequestOptions({ headers: headers });

    return this.http.get(this.appconfigurationService.baseURL + 'PropertyAPI/GetAllPropertyUnits/' + PropertyID)
      .map((response: any) => {
        return response;
      });
  }

  GettAllPropertiesWithSearchText(propertyModel: PropertyModel) {

    let headers = new Headers();
    headers.append('Content-Type', 'application/json');
    let options = new RequestOptions({ headers: headers });
    return this.http.post(this.appconfigurationService.baseURL + 'PropertyAPI/GetAllPropertiesWithSearchText/', propertyModel )
      .map((response: any) => {
        return response;
      });
  }

  destinationDropList() {

    let headers = new Headers();
    headers.append('Content-Type', 'application/json');
    let options = new RequestOptions({ headers: headers });
    return this.http.get(this.appconfigurationService.baseURL + 'PropertyAPI/DestinationDropList/')
      .map((response: any) => {
        return response;
      });
  }


  stateDropdownList() {

    let headers = new Headers();
    headers.append('Content-Type', 'application/json');
    let options = new RequestOptions({ headers: headers });
    return this.http.get(this.appconfigurationService.baseURL + 'PropertyAPI/StateDropList/')
      .map((response: any) => {
        return response;
      });
  

  }

  getCallingScriptdataService(BrandID : number) {

    let headers = new Headers();
    headers.append('Content-Type', 'application/json');
    let options = new RequestOptions({ headers: headers })
    return this.http.get(this.appconfigurationService.baseURL + "PropertyAPI/GetCallingScript/" + BrandID);

  }


}
