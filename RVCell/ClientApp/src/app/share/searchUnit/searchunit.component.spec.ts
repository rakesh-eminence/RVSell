import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SearchunitComponent } from './searchunit.component';

describe('SearchunitComponent', () => {
  let component: SearchunitComponent;
  let fixture: ComponentFixture<SearchunitComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SearchunitComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SearchunitComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
