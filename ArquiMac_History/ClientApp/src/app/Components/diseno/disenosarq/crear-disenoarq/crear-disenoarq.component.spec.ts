import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CrearDisenoarqComponent } from './crear-disenoarq.component';

describe('CrearDisenoarqComponent', () => {
  let component: CrearDisenoarqComponent;
  let fixture: ComponentFixture<CrearDisenoarqComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CrearDisenoarqComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CrearDisenoarqComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
