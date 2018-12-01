import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router,  Params, RoutesRecognized } from '@angular/router';
import { DataService } from '../../data.service'
import { error } from 'protractor';
import { ScriptModel } from '../../models/ScriptModel';

@Component({
  selector: 'app-agent-customer-call-script',
  templateUrl: './agent-customer-call-script.component.html',
  styleUrls: ['./agent-customer-call-script.component.css']
})
export class AgentCustomerCallScriptComponent implements OnInit {
  public BrandID: number = 0
   ScriptModel: Array<ScriptModel> = [];

  constructor(private dataService: DataService, private route: ActivatedRoute, private router: Router) {
  }

  ngOnInit(): void {
    this.router.events.subscribe(val => {
      if (val instanceof RoutesRecognized) {
        this.BrandID = val.state.root.firstChild.params['BrandID'];
        if (this.BrandID > 0) {
          this.getCallingScript();
        }
      }
    });

  }


  getCallingScript() {
    this.dataService.getCallingScriptdataService(this.BrandID).subscribe((response: any) => {
      debugger;
      this.ScriptModel = response;

    },
      error => {

      })

  }

}
