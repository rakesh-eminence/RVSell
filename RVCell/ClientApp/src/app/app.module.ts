import { BrowserModule } from '@angular/platform-browser';
 import { NgModule } from '@angular/core';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { NgxSpinnerModule } from 'ngx-spinner';
import { InfiniteScrollModule } from 'ngx-infinite-scroll';
import { Ng4LoadingSpinnerModule } from 'ng4-loading-spinner';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { AppComponent } from './app.component';
import { AgentSidemenuComponent } from './sidemenu/agent-sidemenu.component';
import { HeaderNavbarComponent } from './menu/header-navbar/header-navbar.component';
import { FooterNavbarComponent } from './menu/footer-navbar/footer-navbar.component';
import { UnitComponent } from './unit/unit.component';
import { MatchingUnitListComponent } from './unit/matching-unit-list/matching-unit-list.component';
import { BrandDetailComponent } from './sidemenu/brandDetail/brand-detail.component';
import { AgentCustomerCallScriptComponent } from './unit/agent-customer-call-script/agent-customer-call-script.component';
import { HomeComponent } from './home/home.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { DataService } from './data.service';
import { AppconfigurationService } from './appconfiguration.service';
import { BrandModel } from './models/modalClass';
import { DataSharingservice } from './DataSharingservice';
import { UnitModalComponent} from './modal/UnitModalComponent'
import { matchingunitSeachComponent} from './unit/matchingunitSeach/matchingunitSeach.component';
import { ModalComponent } from './modal/ng-modal/ng-modal.component';
import { ShareModule } from './share/share.module';
import { Globals } from './globals';
import { ScrollbarModule } from 'ngx-scrollbar';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatSelectModule } from  '@angular/material';

@NgModule({
  declarations: [
    AppComponent,
    AgentSidemenuComponent,
    HeaderNavbarComponent,
    FooterNavbarComponent,
    UnitComponent,
    MatchingUnitListComponent,
    BrandDetailComponent,
    AgentCustomerCallScriptComponent,
    HomeComponent,
    DashboardComponent,
    UnitModalComponent,
    matchingunitSeachComponent,
    ModalComponent,



  ],

 
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    InfiniteScrollModule,
    NgxSpinnerModule,
    Ng4LoadingSpinnerModule.forRoot(),
    NgbModule.forRoot(),
    ShareModule,
    ScrollbarModule,
    MatSelectModule,
    BrowserAnimationsModule,
 
    RouterModule.forRoot([
      { path: 'propertys/brandlanding/:BrandID', component: HomeComponent, pathMatch: 'full' },


    ])
 
  ],
  providers: [DataService, AppconfigurationService, BrandModel, DataSharingservice, Globals],
  bootstrap: [AppComponent, AgentSidemenuComponent, HeaderNavbarComponent, UnitComponent, MatchingUnitListComponent, AgentCustomerCallScriptComponent, FooterNavbarComponent]
})
export class AppModule { }
