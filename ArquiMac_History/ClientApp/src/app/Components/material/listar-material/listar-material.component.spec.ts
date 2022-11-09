import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListarMaterialComponent } from './listar-material.component';

describe('ListarMaterialComponent', () => {
  let component: ListarMaterialComponent;
  let fixture: ComponentFixture<ListarMaterialComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListarMaterialComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListarMaterialComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
