import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AgentSidemenuComponent } from './agent-sidemenu.component';

describe('AgentSidemenuComponent', () => {
  let component: AgentSidemenuComponent;
  let fixture: ComponentFixture<AgentSidemenuComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AgentSidemenuComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AgentSidemenuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
