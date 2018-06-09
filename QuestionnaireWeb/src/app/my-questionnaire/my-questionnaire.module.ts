import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MyQuestionnaireRoutingModule } from './my-questionnaire-routing.module';
import { QuestionnaireLayoutComponent } from './questionnaire-layout/questionnaire-layout.component';
import { LayoutModule } from '@angular/cdk/layout';
import { MatToolbarModule, MatButtonModule, MatSidenavModule, MatIconModule, MatListModule, MatGridListModule, MatCardModule, MatMenuModule } from '@angular/material';
import { QuestionnaireCreateComponent } from './questionnaire-create/questionnaire-create.component';
import { QuestionnaireDashboardComponent } from './questionnaire-dashboard/questionnaire-dashboard.component';

@NgModule({
  imports: [
    CommonModule,
    MyQuestionnaireRoutingModule,
    LayoutModule,
    MatToolbarModule,
    MatButtonModule,
    MatSidenavModule,
    MatIconModule,
    MatListModule,
    MatGridListModule,
    MatCardModule,
    MatMenuModule
  ],
  declarations: [QuestionnaireLayoutComponent, QuestionnaireCreateComponent, QuestionnaireDashboardComponent],
  exports: []
})
export class MyQuestionnaireModule { }
