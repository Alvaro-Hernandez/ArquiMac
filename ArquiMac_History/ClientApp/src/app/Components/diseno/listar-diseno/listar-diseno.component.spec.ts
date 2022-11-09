import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListarDisenoComponent } from './listar-diseno.component';

describe('ListarDisenoComponent', () => {
  let component: ListarDisenoComponent;
  let fixture: ComponentFixture<ListarDisenoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListarDisenoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListarDisenoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
