import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListarImagesarqComponent } from './listar-imagesarq.component';

describe('ListarImagesarqComponent', () => {
  let component: ListarImagesarqComponent;
  let fixture: ComponentFixture<ListarImagesarqComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListarImagesarqComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListarImagesarqComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
