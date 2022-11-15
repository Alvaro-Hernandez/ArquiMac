import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CrearImagedisenoarqComponent } from './crear-imagedisenoarq.component';

describe('CrearImagedisenoarqComponent', () => {
  let component: CrearImagedisenoarqComponent;
  let fixture: ComponentFixture<CrearImagedisenoarqComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CrearImagedisenoarqComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CrearImagedisenoarqComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
