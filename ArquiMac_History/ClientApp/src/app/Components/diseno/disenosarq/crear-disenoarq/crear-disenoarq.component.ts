import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { FormGroup, FormControl } from '@angular/forms';
import { FuncionDisenoArqService } from '../../../../Services/funcion-diseno-arq.service';
import { Diseno } from '../../../../Models/Diseno';

@Component({
  selector: 'app-crear-disenoarq',
  templateUrl: './crear-disenoarq.component.html',
  styleUrls: ['./crear-disenoarq.component.css']
})
export class CrearDisenoarqComponent implements OnInit {

    constructor(private service: FuncionDisenoArqService, private router: Router, private activatedRouter: ActivatedRoute) { }

    datadiseno: Diseno;

    nuevoFormDiseno = new FormGroup({
        id_Admin: new FormControl(''),
        descripcion: new FormControl(''),
        pais_Ubic: new FormControl(''),
        ciudad_Ubic: new FormControl(''),
        estilo_Art: new FormControl(''),
        creado_por: new FormControl('')
    });

  ngOnInit() {
  }

    postDiseno(form: Diseno) {
        this.service.postDiseno(form).subscribe(Data => {
            console.log(Data);
            alert("Datos Registrados");
        });
        this.router.navigate(["ListarDiseno"]);
        window.location.reload();
    }

    Salir() {
        this.router.navigate(["ListarDiseno"]);
    }
}
