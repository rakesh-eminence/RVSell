import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MatchingUnitListComponent } from './matching-unit-list.component';

describe('MatchingUnitListComponent', () => {
  let component: MatchingUnitListComponent;
  let fixture: ComponentFixture<MatchingUnitListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MatchingUnitListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MatchingUnitListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
