import { TestBed } from '@angular/core/testing';

import { FuncionCursosService } from './funcion-cursos.service';

describe('FuncionCursosService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: FuncionCursosService = TestBed.get(FuncionCursosService);
    expect(service).toBeTruthy();
  });
});
