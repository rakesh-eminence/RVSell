import { Component, OnInit } from '@angular/core';
import { PropertyModel } from '../../models/modalClass'
import { DataService } from '../../data.service'
import { DataSharingservice } from '../../DataSharingservice';
import { ActivatedRoute, Params, Router } from '@angular/router';
@Component({
  selector: 'app-matchingunit-Seach',
  templateUrl: './matchingunitSeach.component.html',
  styleUrls: ['./matchingunitSeach.component.css']
})
export class matchingunitSeachComponent implements OnInit {
  public searchText: string = ''
  private propertyUnitListSearch: Array<object> = [];
  constructor(private dataService: DataService, private dataSharingservice: DataSharingservice) { }
  public propertyModel = new PropertyModel()


  SeachCategoryRecord(brandId: any) {
     
    this.dataSharingservice.insertSearchText(this.searchText)//shareing data  

    error => {
    }
  }

  //
  SeachDefaultCategoryRecord() {
    this.searchText = '';
    this.dataSharingservice.insertSearchText(this.searchText)//shareing data

    error => {
    }
  }

  ngOnInit() {
  }

}
