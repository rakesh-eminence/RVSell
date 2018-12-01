import { Component, OnInit, Input, Output } from '@angular/core';
import { DataService } from '../../data.service'
import { DataSharingservice } from '../../DataSharingservice';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { PropertyModel, PropertytabModel } from '../../models/modalClass'
import { debounce } from 'rxjs/operators';
import { debug } from 'util';
import { NgbModal, ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap';
import { error } from 'protractor';
import { propertyUnitModel } from '../../models/propertyUnitModel'
import { Ng4LoadingSpinnerService } from 'ng4-loading-spinner';
import { NgxSpinnerService } from 'ngx-spinner';
import { Globals } from '../../globals'

@Component({
  selector: 'app-matching-unit-list',
  templateUrl: './matching-unit-list.component.html',
  styleUrls: ['./matching-unit-list.component.css']
})
export class MatchingUnitListComponent implements OnInit {
  array = [];
  sum = 25;// show no of record
  throttle = 1;
  scrollDistance = 1;
  scrollUpDistance = 2;
  direction = '';
  modalOpen = true;
  totalRecordsCount = 0;
  @Input() limit: number = 20;
  public isCollapsed = true;
  public ngbCollapse: boolean = false;
  public show: number;
  public showToggale: boolean = false;
  public previousIndex: number = -1;
  selectUnit: any = {};
  private brandId: number = 0;
  private propertyUnitListView: Array<propertyUnitModel> = [];
  public isRecordLoad: boolean = true;


  @Input() private propertytabUnitList: Array<PropertytabModel> = [];


  ////
  @Input() unitData: any;
  //selectUnit: any = {};
  selectUnitdata: any = [];
  selectIndex: number = 0;
  data: any = {
    AccountID: 0,
    AdditionalInformation: '',
    AgeRequirement: 0,
    BookingAvailabilityMessage: "",
    BrandID: 0,
    ChildrenAllowed: false,
    CreateDate: "",
    Description: " ",
    Installation: null,
    LastModifiedByAccountID: 0,
    LastUpdateDate: "",
    MaxOccupancy: 0,
    Name: " ",
    NumberOfBathrooms: 0,
    NumberOfBedrooms: 0,
    PageName: null,
    PetDeposit: "",
    PetSizeMaxWeight: 0,
    PetsAllowed: false,
    PropertyCode: null,
    PropertyID: 0,
    PropertyName: null,
    PropertyTitle: null,
    PropertyUnitID: 549,
    RollawaysAllowed: false,
    SquareFootage: null,
    Timestamp: null
  }
  ////
  //public searchBasiCategory: Array<any> = [
  //  { id: 1, text: 'Name' },
  //  { id: 2, text: 'Alphabets' },
  //  //{ id: 3, text: 'Price Greather than $100' },
  //  //{ id: 4, text: 'Price Less than $1000  ' },
  //];
  constructor(private dataService: DataService, private dataSharingservice: DataSharingservice, private activatedRoute: ActivatedRoute,
    private modalService: NgbModal, private spinner: NgxSpinnerService, private globals: Globals) {


  }
  private urlparm: string = '';
  private urlparmvalue: Array<string> = [];

  content: any[] = new Array();
  public propertyListFilterModel: Array<object> = [];
  public BrandId: number;
  public propertyModel = new PropertyModel()
  closeResult: string;

  loadRecs() {

    //this.limit += 20
    this.propertyModel.BrandID = this.brandId;
    this.propertyModel.TakeRows = 20
    if (this.totalRecordsCount > this.propertyListFilterModel.length) {
      this.propertyModel.SkipRows = this.propertyListFilterModel.length;
      this.getBrandPropertyLoad(this.propertyModel);
    }
  }


  //loading
  getBrandProperty(propertyModel: PropertyModel) {

    this.isRecordLoad = true;
    this.limit = 20;
    this.dataService.GettAllProperties(propertyModel).subscribe((PropertyListFilterModel: any) => {
      if (PropertyListFilterModel.length > 0) {
        this.totalRecordsCount = PropertyListFilterModel[0].TotalRecordsCount
        this.propertyListFilterModel = PropertyListFilterModel;
      }
      this.isRecordLoad = false;
    },
      error => {

      })
  }

  //laodrecs2
  getBrandPropertyLoad(propertyModel: PropertyModel) {
    this.isRecordLoad = true;
    this.dataService.GettAllPropertiesWithSearchText(propertyModel).subscribe((PropertyListFilterModel: PropertyModel[]) => {
      for (var item of PropertyListFilterModel) {
        this.propertyListFilterModel.push(item);
      }
      console.log(this.propertyListFilterModel);
      this.isRecordLoad = false;
    },
      error => {

        this.isRecordLoad = false;
      })
  }


  //searchRec3
  getSearchBrandProperty(propertyModel: PropertyModel) {


    this.isRecordLoad = true
    this.dataService.GettAllPropertiesWithSearchText(propertyModel).subscribe((PropertyListFilterModel: any) => {
      for (var item of PropertyListFilterModel) {
        this.propertyListFilterModel.push(item);


      }
      if (PropertyListFilterModel.length > 0) {
        this.totalRecordsCount = PropertyListFilterModel[0].TotalRecordsCount;
      }
      else {
        this.totalRecordsCount = 0;
      }
      this.isRecordLoad = false;
    },
      error => {
        this.isRecordLoad = false;

      })
  }



  onScrollDown(ev) {

    // add another 20 items
    //const start = this.sum;
    //this.sum += 2;
    //if (this.propertyListFilterModel.length < this.totalRecordsCount) {

    //  this.propertyModel.BrandID = this.propertyModel.BrandID;
    //  this.propertyModel.TakeRows = 59;
    //  this.propertyModel.SkipRows = 0;
    //  this.getBrandPropertyLoad(this.propertyModel);


    //}
  }

  onUp(ev) {
    this.direction = 'up';
  }                                   

  loadMoreProperty() {
    this.propertyModel.BrandID = this.propertyModel.BrandID;
    this.propertyModel.TakeRows = 109;
    this.propertyModel.SkipRows = 0;
    this.getBrandPropertyLoad(this.propertyModel);
  }

  showPopup(index) {
                   
    if (index != this.previousIndex) {
      this.isCollapsed = false;
      this.showToggale = true;
      this.show = index;
      this.previousIndex = index;
    } else {
      this.isCollapsed = !this.isCollapsed;
      this.show = index;
      this.showToggale = (!this.showToggale);
      this.previousIndex = index;
    }

  }

  unitDetailListwView(PropertyID: number) {
    this.dataService.getUnitDetailListwView(PropertyID).subscribe((unitDetailListModal: any[]) => {
      this.propertyUnitListView = unitDetailListModal;
    }, error => {

    })

  }

  unitDetailListwView1(item) {
  
    var data = { PropertyName: "", PropertyID: 0, propertyUnitdropList: [] };
    data.PropertyName = item.Name
    data.PropertyID = item.PropertyID

    if (this.globals.modelClose == 0) {
      this.propertytabUnitList = [];
    }


    var index = this.propertytabUnitList.findIndex(x => x.PropertyID == item.PropertyID)

    if (index == -1) {
      this.dataService.getUnitDetailListwView(item.PropertyID).subscribe((unitDetailListModal: any[]) => {
        for (var item1 of unitDetailListModal) {
          this.propertyUnitListView.push(item1);
          this.propertyUnitListView[0].PropertyName = item.Name
        }
        data.propertyUnitdropList = unitDetailListModal;
        this.propertytabUnitList.push(data);
        this.dataSharingservice.insertUnitmodalPopup(this.propertytabUnitList);
        this.globals.isMinmax = 0;
      }, error => {

      })
    }
    else {
      this.dataSharingservice.insertUnitmodalPopup(this.propertytabUnitList);
      this.globals.isMinmax = 0;
    }

  }
  //searchbase
  getBrandPropertyTextSearch(propertyModel: PropertyModel) {

    this.isRecordLoad = true;
    this.dataService.GettAllPropertiesWithSearchText(propertyModel).subscribe((PropertyListFilterModel: any) => {
      this.isRecordLoad = false;
      //this.totalRecordsCount = PropertyListFilterModel[0].TotalRecordsCount
      this.propertyListFilterModel = PropertyListFilterModel;

    },
      error => {

      })
  }



  //33,35
  ngOnInit() {
    this.spinner.show();
    setTimeout(() => {
      /** spinner ends after 5 seconds */
      this.spinner.hide();
    }, 4000);




    this.activatedRoute.params.subscribe(params => {
      //alert(JSON.parse(params['BrandID']))
      //console.log(JSON.parse(params['BrandID']))
    });

    this.activatedRoute.params.subscribe(params => {
      this.urlparm = window.location.toString();
      this.urlparmvalue = this.urlparm.split("brandlanding/");
      debugger;
      this.brandId = parseInt(this.urlparmvalue[1]);
      this.propertyModel.BrandID = this.brandId;
      this.propertyModel.TakeRows = 20;
      this.propertyModel.SkipRows = 0;
      this.getBrandProperty(this.propertyModel);

      this.dataSharingservice.insertBrandDetail(this.brandId)
      this.globals.brandIdGlobal = this.brandId;
    });
    // text search
    this.dataSharingservice.listeninsertSearchText().subscribe((searchText: any) => {

      if (this.globals.RoomMinimum == 0 && this.globals.RoomMaximum == 0 && this.globals.BathRoomMinimum == 0 && this.globals.BathRoomMaximum == 0 && this.globals.DestinationTypeID == 0 && this.globals.StateID == 0 && this.globals.searchText == "") {
        this.propertyModel.TakeRows = 20;
        this.propertyModel.SkipRows = 0;
        this.getBrandProperty(this.propertyModel); // defaul record
        return;
      }
      this.propertyModel.TakeRows = 20;
      this.propertyModel.SkipRows = 0;
      this.propertyListFilterModel = [];
      if (searchText == -1) {
        //this.propertyListFilterModel = [];
        //this.propertyModel.BrandID = this.propertyModel.BrandID;
        //this.propertyModel.PropertyName = this.globals.searchText;
        //this.getSearchBrandProperty(this.propertyModel)
        this.propertyListFilterModel = [];
        this.propertyModel.BrandID = this.propertyModel.BrandID;
        this.propertyModel.RoomMinimum = this.globals.RoomMinimum;
        this.propertyModel.RoomMaximum = this.globals.RoomMaximum;
        this.propertyModel.BathRoomMinimum = this.globals.BathRoomMinimum;
        this.propertyModel.BathRoomMaximum = this.globals.BathRoomMaximum;
        this.propertyModel.DestinationTypeID = this.globals.DestinationTypeID;
        this.propertyModel.StateID = this.globals.StateID;
        this.propertyModel.PropertyName = this.globals.searchText;
        this.getSearchBrandProperty(this.propertyModel)
      }

      else if (searchText == -2) {
        this.propertyModel.TakeRows = 20;
        this.propertyModel.SkipRows = 0;
        this.getBrandProperty(this.propertyModel); // defaul record
      }
      else {
        this.propertyListFilterModel = [];
        this.propertyModel.BrandID = this.propertyModel.BrandID;
        this.propertyModel.RoomMinimum = this.globals.RoomMinimum;
        this.propertyModel.RoomMaximum = this.globals.RoomMaximum;
        this.propertyModel.BathRoomMinimum = this.globals.BathRoomMinimum;
        this.propertyModel.BathRoomMaximum = this.globals.BathRoomMaximum;
        this.propertyModel.DestinationTypeID = this.globals.DestinationTypeID;
        this.propertyModel.StateID = this.globals.StateID;
        this.propertyModel.PropertyName = this.globals.searchText;
        this.getSearchBrandProperty(this.propertyModel)
      }
    })

    //search button
    this.dataSharingservice.listensideUnitFilterParameter().subscribe((propertyModel: any) => {

      if (this.globals.RoomMinimum == 0 && this.globals.RoomMaximum == 0 && this.globals.BathRoomMinimum == 0 && this.globals.BathRoomMaximum == 0 && this.globals.DestinationTypeID == 0 && this.globals.StateID == 0 && this.globals.searchText == "") {
        this.propertyModel.TakeRows = 20;
        this.propertyModel.SkipRows = 0;
        this.getBrandProperty(this.propertyModel); // defaul record
        return;
      }
      this.propertyModel.TakeRows = 20;
      this.propertyModel.SkipRows = 0;
      this.propertyListFilterModel = [];
      this.propertyModel.BrandID = this.propertyModel.BrandID;
      this.propertyModel.RoomMinimum = this.globals.RoomMinimum;
      this.propertyModel.RoomMaximum = this.globals.RoomMaximum;
      this.propertyModel.BathRoomMinimum = this.globals.BathRoomMinimum;
      this.propertyModel.BathRoomMaximum = this.globals.BathRoomMaximum;
      this.propertyModel.DestinationTypeID = this.globals.DestinationTypeID;
      this.propertyModel.StateID = this.globals.StateID;
      this.propertyModel.PropertyName = this.globals.searchText;
      this.getSearchBrandProperty(this.propertyModel);

    })

  }



}
