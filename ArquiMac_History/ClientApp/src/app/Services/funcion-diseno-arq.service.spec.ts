import { TestBed } from '@angular/core/testing';

import { FuncionDisenoArqService } from './funcion-diseno-arq.service';

describe('FuncionDisenoArqService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: FuncionDisenoArqService = TestBed.get(FuncionDisenoArqService);
    expect(service).toBeTruthy();
  });
});
