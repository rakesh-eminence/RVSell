import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AgentCustomerCallScriptComponent } from './agent-customer-call-script.component';

describe('AgentCustomerCallScriptComponent', () => {
  let component: AgentCustomerCallScriptComponent;
  let fixture: ComponentFixture<AgentCustomerCallScriptComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AgentCustomerCallScriptComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AgentCustomerCallScriptComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
