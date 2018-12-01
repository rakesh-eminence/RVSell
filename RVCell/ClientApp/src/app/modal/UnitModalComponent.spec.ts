import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UnitModalComponent } from './UnitModalComponent';

describe('HomeComponent', () => {
  let component: UnitModalComponent;
  let fixture: ComponentFixture<UnitModalComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [UnitModalComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UnitModalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
