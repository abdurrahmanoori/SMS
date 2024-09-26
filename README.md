# Survey Management System

## Overview

The Survey Management System is designed to manage multi-language surveys, track survey responses, and handle various survey instances over time. The system allows you to:
- Define surveys with multiple questions.
- Handle different survey instances (activation periods) for reactivating surveys in future periods.
- Manage translations of survey questions and answers in multiple languages.
- Track respondent answers and analyze their choices based on survey questions.
  
The system is built to support flexibility in defining survey questions, answer options, and handling multi-lingual support via translation tables.

---

## ERD Overview

The system's database structure is centered around the following core entities:
- **Surveys**: Stores the general information of surveys.
- **SurveyInstances**: Tracks different periods when the survey is active.
- **Questions**: Holds the survey's questions.
- **AnswerOptions**: Stores possible answers to the questions.
- **Respondent**: Tracks the user who participated in the survey.
- **SurveyResponse**: Captures respondents' survey answers.
- **SurveyResponseDetails**: Records detailed answers for each question.
- **Languages**: Manages language codes for multi-language support.
- **QuestionTranslations**: Stores translations of questions.
- **AnswerOptionsTranslations**: Stores translations of answer options.
  
The ERD provides a structured way to manage surveys and responses across multiple languages, while tracking participation and responses for future analysis.

---

## Key Features

### 1. Multi-Language Support
- Surveys, questions, and answer options can be defined in multiple languages.
- Translations are stored in separate tables (`SurveyTranslations`, `QuestionTranslations`, `AnswerOptionsTranslations`), allowing users to participate in their preferred language.

### 2. Survey Instances and Activation History
- A survey can be activated multiple times in different periods, each represented by a **Survey Instance**.
- Survey instances allow reactivation of the same survey in the future without modifying the original survey data.
  
### 3. Answer Tracking
- Respondents' answers are captured and stored, allowing analysis of response trends and data across various demographics.
- The **SurveyResponseDetails** table captures detailed answers for both multiple-choice and free-text questions.

### 4. SurveyInstanceQuestion Association
- Each survey instance is linked to a specific set of questions, allowing flexibility to change questions between instances of the same survey.

---

## Entity Breakdown

### Surveys
- **SurveyID**: Primary Key
- **CreatedDate**: Date the survey was created
- **IsActive**: Whether the survey is currently active
- **SurveyDescription**: A description of the survey

### SurveyInstances
- **SurveyInstanceID**: Primary Key
- **SurveyID**: Foreign Key linking to Surveys
- **ActivationDate**: Start date of the survey instance
- **DeactivationDate**: End date of the survey instance
- **IsActive**: Flag indicating if the survey instance is active

### Questions
- **QuestionID**: Primary Key
- **SurveyID**: Foreign Key linking to Surveys
- **QuestionType**: Type of question (e.g., multiple choice, free text)
- **IsRequired**: Whether the question is mandatory
  
### AnswerOptions
- **AnswerOptionID**: Primary Key
- **QuestionID**: Foreign Key linking to Questions
- **AnswerOptionText**: The text of the answer option

### Respondent
- **RespondentID**: Primary Key
- **PhoneNumber**, **Email**, **Province**, **DateOfBirth**, **Gender**, etc.

### SurveyResponse
- **SurveyResponseID**: Primary Key
- **SurveyInstanceID**: Foreign Key linking to SurveyInstances
- **RespondentID**: Foreign Key linking to Respondent
- **ResponseDate**: The date the respondent completed the survey
  
### SurveyResponseDetails
- **SurveyResponseDetailID**: Primary Key
- **SurveyResponseID**: Foreign Key linking to SurveyResponse
- **SurveyInstanceQuestionID**: Foreign Key linking to SurveyInstanceQuestion
- **AnswerOptionID**: Foreign Key linking to AnswerOptions
- **FreeTextAnswer**: The text entered for open-ended questions

### Languages
- **LanguageID**: Primary Key
- **LanguageCode**: Code of the language (e.g., 'en' for English)
- **LanguageName**: Name of the language (e.g., English, Spanish)

---

## Setup Instructions

### 1. Database
The ERD requires a relational database to manage the survey system. You can use any SQL-based database like MySQL, PostgreSQL, or SQL Server.

### 2. Clone the Repository

```bash
git clone https://github.com/your-repository-url.git
