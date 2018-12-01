import { Component, OnInit, Directive, Inject, Output, EventEmitter } from '@angular/core';
import { DOCUMENT } from '@angular/common';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { DataService } from '../../data.service'
import 'rxjs/add/operator/filter';
import { HttpClient } from '@angular/common/http';
import { DataSharingservice } from '../../DataSharingservice';
import { AppconfigurationService } from '../../appconfiguration.service';
import { BrandModel } from './../../models/modalClass';
import { debug } from 'util';
import { InfiniteScrollModule } from 'ngx-infinite-scroll';


@Component({
  selector: 'app-brand-detail',
  templateUrl: './brand-detail.component.html',
  styleUrls: ['./brand-detail.component.css']
})
export class BrandDetailComponent implements OnInit {

 public brandModel  =  {BrandID:0,BrandName:null,Timestamp:null,RoomCount:0,HoursOfOperation:null,PmsCmsLinks:null,Poc:null,MarketsServed:null,GroupsAllowed:false,GiftCertificates:null,CallScript:null,LogoFileID:0,Faq:null,Policy:null,SocialFacebook:null,SocialTwitter:null,SocialYouTube:null,SocialLinkedIn:null,SalesCallerID:null,Website:null,MaintenanceEmail:null,SalesEmail:null,GuestUseEmail:null,PhoneMainLocal:null,Fax:null,PhoneTollFree:null,EmergencyContact:null,MaintenanceContact:null,Avatar:null,AvatarMimeType:null,Benefits:null,lstBrands:null}
   
  isLoaded = false;
  constructor(private dataService: DataService, private http: HttpClient, private appconfigurationService: AppconfigurationService,
    private activatedRoute: ActivatedRoute, private router: Router, private dataSharingservice: DataSharingservice) {

  }
  htmlStrfaq: string = '';
  htmlStrPolicy: string = '';
  htmlAdditionalInformation: string = '';
  htmlMaintenanceContact: string = '';
  private brandId: number = 0;

  public propertyModel = [];
  private contacts: Array<object> = [];
  private urlparm: string = '';
  private urlparmvalue: Array<string> = [];



  //1
  getBrand(brandId: any) {
    debugger;
    this.dataService.getBrand(brandId).subscribe(BrandModel => {
      //this.getBrandProperty(this.brandId)

     
      this.brandModel = BrandModel;
      this.htmlStrfaq = BrandModel.Faq == undefined || BrandModel.Faq == null ? '' : BrandModel.Faq.replace(/(?:\r\n|\r|\n)/g, '<br />');
      this.htmlStrPolicy = BrandModel.Policy == null ? '' : BrandModel.Policy.replace(/(?:\r\n|\r|\n)/g, '<br />');
      this.htmlAdditionalInformation = BrandModel.AdditionalInformation == undefined || BrandModel.AdditionalInformation == null ? '' : BrandModel.AdditionalInformation.replace(/(?:\r\n|\r|\n)/g, '<br />');
      this.htmlMaintenanceContact = BrandModel.MaintenanceContact == undefined || BrandModel.MaintenanceContact.replace(/(?:\r\n|\r|\n)/g, '<br />');


    },
      error => {
      })
  }


  //2
  getBrandProperty(brandId: any) {
    this.dataService.getBrandProperty(brandId).subscribe(PropertyModel => {
      this.propertyModel = PropertyModel;
      this.dataSharingservice.insertBrandIdMarchingUnit(this.brandId)//shareing data
    },
      error => {
      })
  }

  websiteUrl(url: any) {
    if (url != '' && url != undefined) {
      window.open(url, "_blank");
    }
  }

  ngOnInit() {

    this.dataSharingservice.listenBrandDetail().subscribe((BrandId: any) => {
      this.getBrand(BrandId);
    })




  }
}

