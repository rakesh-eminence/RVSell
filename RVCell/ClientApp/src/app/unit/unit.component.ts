import { Component, OnInit } from '@angular/core';
import { DataSharingservice } from '../DataSharingservice';
import { DataService } from '../data.service';
import { DestinationModel, StateModel, PropertyModel } from '../models/modalClass'
import { Globals } from '../globals'
import { debounce } from 'rxjs/operator/debounce';
@Component({
  selector: 'app-unit',
  templateUrl: './unit.component.html',
  styleUrls: ['./unit.component.css']
})
export class UnitComponent implements OnInit {
  public searchText: string = ''
  public destinationModelList: Array<DestinationModel> = [{ DestinationTypeID: 0, DestinationTypeName: "Destination type" }];
  public selectOption: any;
  public selectLanguage: any;
  public destinationModel: Object = { DestinationTypeID: 0, DestinationTypeName: "Destination type" };
  public destinationStateModelList: Array<StateModel> = [{ StateID: 0, Name: "Select State" }];
  public sateModel: Object = { StateID: 0, Name: "Select State" }
  public destinationSelectType : 0
  public propertyFilterDestModel = { RoomMinimum: 0, RoomMaximum: 0, BathRoomMinimum: 0, BathRoomMaximum: 0, DestinationTypeID: 0, StateID:0} ;
  //data: MyType = <MyType>{};

  constructor(private dataSharingservice: DataSharingservice, private dataService: DataService, private globals: Globals, ) {

  }




  seachAllDefualtRecord() {
 
    this.searchText ="-2"
    this.dataSharingservice.insertSearchText(this.searchText)//shareing data
    error => {
    }
  }

  destinationDropList() {
    this.dataService.destinationDropList().subscribe((PropertyListFilterModel : any) => {
      for (var item of PropertyListFilterModel) {
        this.destinationModelList.push(item);

      }
      this.destinationModel = this.destinationModelList[0];
      this.stateDropdownList();
    },
      error => {

      })
  }

  stateDropdownList() {
    this.dataService.stateDropdownList().subscribe((PropertyListStateModelList: any) => {
  
      for (var item of PropertyListStateModelList) {
        this.destinationStateModelList.push(item);

      }
      this.sateModel = this.destinationStateModelList[0];
    },
      error => {

      })
  }   


  onChangeMinRoom(value) {
 
    this.propertyFilterDestModel.RoomMinimum = value;
    this.globals.RoomMinimum = value;
  }
  
  onChangeMaxRoom(value) {
   
    this.propertyFilterDestModel.RoomMaximum = value;
    this.globals.RoomMaximum = value;
  }

  onChangeMinBathRoom(value) {
    this.propertyFilterDestModel.BathRoomMinimum = value;
    this.globals.BathRoomMinimum = value;
  }
  onChangeMaxBathRoom(value) {
    this.propertyFilterDestModel.BathRoomMaximum = value;
    this.globals.BathRoomMaximum = value;
  }

  onSelectdestinationChange(destinationModel) {

    this.propertyFilterDestModel.DestinationTypeID = destinationModel.DestinationTypeID;
    this.globals.DestinationTypeID = destinationModel.DestinationTypeID;
  }

  onSelectStateChange(state) {
    this.propertyFilterDestModel.StateID = state.StateID;
    this.globals.StateID = state.StateID
  }
  //////////////////Collapse///
  onChangeMinRoomCollapse(value) {

    this.propertyFilterDestModel.RoomMinimum = value;
    this.globals.RoomMinimum = value;
    this.seachFilterProperty();
  }

  onChangeMaxRoomCollapse(value) {

    this.propertyFilterDestModel.RoomMaximum = value;
    this.globals.RoomMaximum = value;
    this.seachFilterProperty();
  }

  onChangeMinBathRoomCollapse(value) {
    this.propertyFilterDestModel.BathRoomMinimum = value;
    this.globals.BathRoomMinimum = value;
    this.seachFilterProperty();
  }
  onChangeMaxBathRoomCollapse(value) {
    this.propertyFilterDestModel.BathRoomMaximum = value;
    this.globals.BathRoomMaximum = value;
    this.seachFilterProperty();
  }

  onSelectdestinationChangeCollapse(destinationModel) {

    this.propertyFilterDestModel.DestinationTypeID = destinationModel.DestinationTypeID;
    this.globals.DestinationTypeID = destinationModel.DestinationTypeID;
    this.seachFilterProperty();

  }

  onSelectStateChangeCollapse(StateModel) {
    this.propertyFilterDestModel.StateID = StateModel.StateID;
    this.globals.StateID = StateModel.StateID;
    this.seachFilterProperty();
  }

  searchCollapse(searchTextCollapse) {
    if (this.globals.searchText.length > 2 ) {
      this.globals.searchText 
      this.seachFilterProperty();
    }
  }

   /////////////////Collapse////


  searchParameterModel() {

  }

  seachFilterProperty() {

    this.dataSharingservice.setSideUnitFilterParameter(this.propertyFilterDestModel)//shareing data
    error => {
    }

  }


  ngOnInit() {
    setTimeout(() => {
      /** spinner ends after 5 seconds */
      this.destinationDropList();
    }, 1000);
 

  }

}
