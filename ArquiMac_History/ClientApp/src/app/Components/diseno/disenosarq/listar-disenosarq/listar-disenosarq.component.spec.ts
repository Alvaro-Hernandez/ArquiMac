import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListarDisenosarqComponent } from './listar-disenosarq.component';

describe('ListarDisenosarqComponent', () => {
  let component: ListarDisenosarqComponent;
  let fixture: ComponentFixture<ListarDisenosarqComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListarDisenosarqComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListarDisenosarqComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
