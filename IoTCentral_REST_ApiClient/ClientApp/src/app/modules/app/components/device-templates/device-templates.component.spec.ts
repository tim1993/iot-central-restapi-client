import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DeviceTemplatesComponent } from './device-templates.component';

describe('DeviceTemplatesComponent', () => {
  let component: DeviceTemplatesComponent;
  let fixture: ComponentFixture<DeviceTemplatesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DeviceTemplatesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DeviceTemplatesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
