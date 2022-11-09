import { TestBed } from '@angular/core/testing';

import { FuncionImagenArqService } from './funcion-imagen-arq.service';

describe('FuncionImagenArqService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: FuncionImagenArqService = TestBed.get(FuncionImagenArqService);
    expect(service).toBeTruthy();
  });
});
