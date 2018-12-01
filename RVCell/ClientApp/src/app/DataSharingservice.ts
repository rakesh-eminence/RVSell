import { Injectable } from '@angular/core';
import { Subject, Observable } from 'rxjs';


@Injectable()
export class DataSharingservice {

  getMehtodBrandId$: Observable<any>;

  ShareBrandId: string[] = [];

  private myMethodSubject = new Subject<any>();
  private _listnersBrandDetail = new Subject<any>();
  private _listners = new Subject<any>();
  private _listSearchText = new Subject<any>();
  public _listFilterParameterProperty = new Subject<any>();
  public _listPopupModeldata = new Subject<any>();
  public _listPopupModelunitDataClear = new Subject<any>();
  public _listUnitmodalPopup = new Subject<any>();


  constructor() {
    this.getMehtodBrandId$ = this.myMethodSubject.asObservable();
  }


  insertBrandDetail(BrandId: number) {
    this._listnersBrandDetail.next(BrandId);

  }
  listenBrandDetail() {
  return  this._listnersBrandDetail.asObservable();

  }

  insertBrandId(BrandId: number) {
    this.myMethodSubject.next(BrandId);
  }


  listeninsertBrandIdMarchingUnit(): Observable<any> {
       return this._listners.asObservable();
    }

  insertBrandIdMarchingUnit(brandId: any) {
    this._listners.next(brandId);
  }

  insertSearchText(searchText: any) {
    this._listSearchText.next(searchText);
  }
  listeninsertSearchText(): Observable<any> {
    return this._listSearchText.asObservable();
  }


  setSideUnitFilterParameter(unitdata: any) {
    this._listFilterParameterProperty.next(unitdata)
  }
  listensideUnitFilterParameter(): Observable<any>{
    return this._listFilterParameterProperty.asObservable();
  }



        
  insertUnitmodalPopup(unitdata: any) {
    this._listUnitmodalPopup.next(unitdata);

  }
  listUnitmodalPopup(): Observable<any>{
    return this._listUnitmodalPopup.asObservable();

  }


  insertModelunitDataClear() {
    this._listPopupModelunitDataClear.next();

  }
  listenModelunitDataClear(): Observable<any> {
    return this._listPopupModelunitDataClear.asObservable();

  }
  
}
