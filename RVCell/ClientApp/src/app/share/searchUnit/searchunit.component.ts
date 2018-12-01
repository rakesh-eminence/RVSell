import { Component, OnInit, Input } from '@angular/core';
import { DataService } from '../../data.service'
import { DataSharingservice } from '../../DataSharingservice';
import { PropertyModel } from '../../models/modalClass';
import { Globals } from '../../globals';
@Component({
  selector: 'app-search-unit',
  templateUrl: './searchunit.component.html',
  styleUrls: ['./searchunit.component.css']
})
export class SearchunitComponent implements OnInit {
  private searchText: string = ''
  constructor(private dataService: DataService, private dataSharingservice: DataSharingservice, public globals: Globals) {
    this.searchText = globals.searchText;
  }

  ngOnInit() {
  }

  private propertyModel = new PropertyModel()


  //public searchBasiCategory: Array<any> = [
  //  { id: 1, text: 'Name' },
  //  { id: 2, text: 'Alphabets' },
  //  //{ id: 3, text: 'Price Greather than $100' },
  //  //{ id: 4, text: 'Price Less than $1000  ' },
  //];

  SeachCategoryClick(text) {

  }


  SeachCategoryRecord(search: any) {

    this.dataSharingservice.insertSearchText(this.searchText)//shareing data
    error => {
    }
  }

  
  SeachDefaultCategoryRecord() {

    this.globals.searchText = "";
    this.searchText = '-1'
    this.dataSharingservice.insertSearchText(this.searchText)//shareing data

    error => {
    }
  }

  enterSearchResult(event: any) {
    if (event.keyCode == 13) {
      this.dataSharingservice.insertSearchText(this.searchText)//shareing data
      error => {
      }
    } else {
    }
  }



}
