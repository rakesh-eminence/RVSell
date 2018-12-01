import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { matchingunitSeachComponent } from './matchingunitSeach.component';

describe('HomeComponent', () => {
  let component: matchingunitSeachComponent;
  let fixture: ComponentFixture<matchingunitSeachComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [matchingunitSeachComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(matchingunitSeachComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
