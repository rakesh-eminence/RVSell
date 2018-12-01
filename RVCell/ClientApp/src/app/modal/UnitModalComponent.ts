import { Component, OnInit, Input } from '@angular/core';
import { FormControl } from '@angular/forms';
import { debounce } from 'rxjs/operators';
import { DataSharingservice } from '../DataSharingservice'
declare var $: any;
import { Globals } from '../globals';
import { global } from '@angular/core/src/util';
import { parse } from 'path';
@Component({
  selector: 'app-home-UnitModal',
  templateUrl: './UnitModalComponent.html',
  styleUrls: ['./UnitModalComponent.css']
})
export class UnitModalComponent implements OnInit {


  @Input() unitData: any;
  selectUnit: any = {

  };

 
  selectUnitdata: any = [];
  selectIndex: number = 0;
  data: any = {
    PropertyUnitID: 0,
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
    RollawaysAllowed: false,
    SquareFootage: null,
    Timestamp: null
  };


 //public selectedValue: {};
  constructor(private dataSharingservice: DataSharingservice, private globals: Globals) {

  }

    


  ngOnInit() {

    for (let i = 0; i < 1; i++) {
      this.selectUnitdata.push(this.data);
    }


    this.dataSharingservice.listUnitmodalPopup().subscribe((unitdata: any) => {
      debugger;
      //var x1 = '[{ "PropertyName": "A1", "PropertyID": 541, "propertyUnitdropList": [] },{ "PropertyName": "A2", "PropertyID": 541, "propertyUnitdropList": [] },{ "PropertyName": "A3", "PropertyID": 541, "propertyUnitdropList": [] },{ "PropertyName": "ACA-Suite SBMAR11", "PropertyID": 541, "propertyUnitdropList": [] },{ "PropertyName": "ACA-Suite SBMAR11", "PropertyID": 541, "propertyUnitdropList": [] }]';
      //this.unitData = JSON.parse(x1);
      var tempObject = {
        AccountID: 0,
        AdditionalInformation: "",
        AgeRequirement: 0,
        BookingAvailabilityMessage: "",
        BrandID: 0,
        ChildrenAllowed: false,
        CreateDate: "",
        Description: "",
        Installation: null,
        LastModifiedByAccountID: 0,
        LastUpdateDate: "",
        MaxOccupancy: 0,
        Name: "--select--",
        NumberOfBathrooms: 0,
        NumberOfBedrooms: 0,
        PageName: null,
        PetDeposit: "",
        PetSizeMaxWeight: 0,
        PetsAllowed: false,
        PropertyCode: null,
        PropertyID: -1,
        PropertyName: null,
        PropertyTitle: null,
        PropertyUnitID: 0,
        RollawaysAllowed: false,
        SquareFootage: null,
        Timestamp: null,
      }
      debugger;
      this.unitData = unitdata;
      //var index1 = this.unitData[0].propertyUnitdropList.findIndex(x => x.PropertyID == -1)

      //if (index1 == -1) {
      //  this.unitData[0].propertyUnitdropList.push(tempObject)
      //  this.selectUnit["0"] = this.unitData[0].propertyUnitdropList[this.unitData[0].propertyUnitdropList.length - 1]
      //}
      let index = this.unitData.length - 1
      $(".mymodal").removeClass("min");
      document.getElementById("modaldrag").click();
      if (unitdata.length == 1) {
        this.globals.modelClose = 1;
      }

      this.selectTab(index);
    })

    this.dataSharingservice.listenModelunitDataClear().subscribe((unitdata: any) => {
      debugger;
      this.unitData = [];
      this.selectUnitdata = [];
    })

  }


  crossTab(index: any) {
    debugger;
    this.unitData.splice(index, 1);
    this.selectUnitdata.splice(index, 1);
  }

  selectTab(index: any) {
    this.selectIndex = index;
    if (this.selectUnitdata.length < this.unitData.length) {
      for (let i = 1; i < this.unitData.length; i++) {
        this.selectUnitdata.push(this.data)
      }
    }
  }



  onSelectChange(index2: any, item: any,event: any) {
    debugger;
    this.selectUnit = item;
    this.selectUnitdata[index2] = item
  }




  ngAfterViewInit() {

    var hidWidth;
    var scrollBarWidths = 20;

    var widthOfList = function () {
      var itemsWidth = 0;
      $('.list li').each(function () {
        var itemWidth = $(this).outerWidth();
        itemsWidth += itemWidth;
      });
      return itemsWidth;
    };

    var widthOfHidden = function () {
      return (($('.wrapper').outerWidth()) - widthOfList() - getLeftPosi()) - scrollBarWidths;
    };

    var getLeftPosi = function () {
      return $('.list').position().left;
    };

    var reAdjust = function () {
      if (($('.wrapper').outerWidth()) < widthOfList()) {
        $('.scroller-right').show();
      }
      else {
        $('.scroller-right').hide();
      }

      if (getLeftPosi() < 0) {
        $('.scroller-left').show();
      }
      else {
        $('.item').animate({ left: "-=" + getLeftPosi() + "px" }, 'slow');
        $('.scroller-left').hide();
      }
    }

    reAdjust();

    //$(window).on('resize', function (e) {
    //  reAdjust();
    //});

    $(window).on('#modal-2', function (e) {
      reAdjust();
    });
    var rightvalue = 0
    var leftvalue = 0;
    var hidevalue = 0
    $('.scroller-right').click(function () {
      debugger

      var itemsWidth = 0;

      $('.list li').each(function (index, value) {
        debugger;
        var calssexit = $(value).attr('class').split(' ')[0];
        var itemWidth = $(this).width();
        var itemouterWidth = $(this).outerWidth();
        var licustclass = 'tabmenu_' + (hidevalue - 1);
        if (calssexit == licustclass ) {
          $('.' + calssexit).show();
          hidevalue--;
          return false
        }

      });



      //$('.scroller-left').fadeIn('slow');
      //$('.scroller-right').fadeOut('slow');


    });



    $('.scroller-left').click(function () {
      debugger


      $('.list li').each(function (index1, value) {
        debugger;
        var calssexit = $(value).attr('class').split(' ')[0];
        var itemWidth = $(this).width();

        var itemouterWidth = $(this).outerWidth();
        var licustclass = 'tabmenu_' + hidevalue

        //if (index1 == itemsWidth) {
        //  $('.list').animate({ left: "-=" + itemWidth + "px" }, 'slow', function () {

        //  });

        //}
        if ($('.list li').length == 1) {
          return false;
        }
        else if (($('.list li').length-1) == index1 ) {
          return false;
        }
        else if (calssexit == licustclass ) {
          //$('.list').animate({ left: "+=" + itemWidth + "px" }, 'slow', function () {
          //});
          $('.' + calssexit).hide();
          $('.scroller-right').fadeIn('slow')
          hidevalue++;
          return false;
        }
      });



      //$('.scroller-right').fadeIn('slow');
      //$('.scroller-left').fadeOut('slow');


      rightvalue = rightvalue - 1;

    });




  }
}
//https://material.angularjs.org/latest/demo/tabs
