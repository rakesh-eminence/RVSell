import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { SearchunitComponent } from './searchunit/searchunit.component';

@NgModule({
  imports: [
    CommonModule,
    FormsModule
  ],
  exports: [
    SearchunitComponent
  ],
  declarations: [SearchunitComponent]
})
export class ShareModule { }
