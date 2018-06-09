import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HomeRoutingModule } from './home-routing.module';
import { HomeComponent } from './home/home.component';
import { QuestionnaireCommonModule } from '../questionnaire-common/questionnaire-common.module';

@NgModule({
  imports: [
    CommonModule,
    HomeRoutingModule,
    QuestionnaireCommonModule
  ],
  declarations: [HomeComponent]
})
export class HomeModule { }
