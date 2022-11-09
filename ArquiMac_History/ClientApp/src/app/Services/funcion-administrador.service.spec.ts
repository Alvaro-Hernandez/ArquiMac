import { TestBed } from '@angular/core/testing';

import { FuncionAdministradorService } from './funcion-administrador.service';

describe('FuncionAdministradorService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: FuncionAdministradorService = TestBed.get(FuncionAdministradorService);
    expect(service).toBeTruthy();
  });
});
