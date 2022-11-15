import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { FormGroup, FormControl } from '@angular/forms';
import { FuncionImagenArqService } from 'src/app/Services/funcion-imagen-arq.service';
import { ImagenDiseno } from '../../../../Models/ImagenDiseno';
@Component({
  selector: 'app-crear-imagedisenoarq',
  templateUrl: './crear-imagedisenoarq.component.html',
  styleUrls: ['./crear-imagedisenoarq.component.css']
})
export class CrearImagedisenoarqComponent implements OnInit {

    constructor(private service: FuncionImagenArqService, private router: Router, private activatedRouter: ActivatedRoute) { }

    dataImgDiseno: ImagenDiseno;

    nuevoFormImgArq = new FormGroup({
        id_Diseno: new FormControl(''),
        almacenamiento: new FormControl('')
    });

  ngOnInit() {
  }

    postImgDiseno(form: ImagenDiseno) {
        this.service.postImgDiseno(form).subscribe(Data => {
            console.log(Data);
            alert("Datos Registrados");
        });
    }

    Salir() {
        this.router.navigate(["ListarImagesarq"]);
    }
}
