import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FuncionImagenArqService } from 'src/app/Services/funcion-imagen-arq.service';
import { ImagenDiseno } from '../../../../Models/ImagenDiseno';

@Component({
  selector: 'app-listar-imagesarq',
  templateUrl: './listar-imagesarq.component.html',
  styleUrls: ['./listar-imagesarq.component.css']
})
export class ListarImagesarqComponent implements OnInit {

    constructor(private service: FuncionImagenArqService, private router: Router) { }

    disenosImg: ImagenDiseno[];

    ngOnInit() {
        this.service.getImgDiseno()
            .subscribe(Data => this.disenosImg = Data);
    }

}
