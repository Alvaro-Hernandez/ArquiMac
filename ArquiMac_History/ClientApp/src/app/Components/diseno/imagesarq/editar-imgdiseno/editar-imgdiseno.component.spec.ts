import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EditarImgdisenoComponent } from './editar-imgdiseno.component';

describe('EditarImgdisenoComponent', () => {
  let component: EditarImgdisenoComponent;
  let fixture: ComponentFixture<EditarImgdisenoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EditarImgdisenoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EditarImgdisenoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
