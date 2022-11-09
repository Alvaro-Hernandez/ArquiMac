import { TestBed } from '@angular/core/testing';

import { FuncionMaterialService } from './funcion-material.service';

describe('FuncionMaterialService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: FuncionMaterialService = TestBed.get(FuncionMaterialService);
    expect(service).toBeTruthy();
  });
});
