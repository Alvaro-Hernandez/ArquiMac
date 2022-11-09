import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EditarDisenoarqComponent } from './editar-disenoarq.component';

describe('EditarDisenoarqComponent', () => {
  let component: EditarDisenoarqComponent;
  let fixture: ComponentFixture<EditarDisenoarqComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EditarDisenoarqComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EditarDisenoarqComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
