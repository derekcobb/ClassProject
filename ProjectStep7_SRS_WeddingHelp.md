## Name: Project Step 6-SRS

## Author: Derek Cobb

## Date: August 19 2019

---------------------------------------------------------------------

3. Specific requirements
This sections contains all of the functional and quality requirements of the system. It also gives a detailed description
of the system and all its features.

3.1 External interface Requirements
This section provides a detailed description of all inputs into and outputs from the system. It also gives a description
of the hardware, software and communication interfaces and provides basic prototypes of the user interface.

3.1.1 User interfaces
A first-time user of the mobile application should see the log-in page when he/she opens the application. If the user
has not registered, he/she should be able to do that on the log-in page.

If the user is not a first-time user, he/she should see their personal accoutn after log-in. Here the user can begin
creating a not outfit profile or checking on the status of their current outfit profile. The user should be able to
edit their personal contact information and/or edit outfit requirements. Users will be able to edit contact information
such as email, phone number, name etc. The outfit profile can be updated concerning the persons measurements, full-body
photo displayed, and the description of the initial desired outfit.

................


3.1.2 Hardware Interfaces
Since neither the mobile application nor the web portal have any designated hardware, it does not have any direct hardware
interfaces. The physical GPS is managed by the GPS application in the mobile phone and the hardware connection to the database
server is managed by the underlying operating system on the mobile phone and the web server.

3.1.3 Software Interfaces

3.1.4 Communication Interfacese
The communication between the different parts of the system is important since they depend on each other. However, in what way
the communication is achieved is not important for the system and is there force handled by the underlying operating systems for
both the mobile application and the web portal.


## 3.2 Functional Requirements
This section includes the requirements that specify all the fundamental actions of the software system.

3.2.1 USer Class 1 - The User

# 3.2.1.1 Functional Requirement 1.1

ID: FR1
TITLE: Download mobile applicaiton
DESC: A user hould be able to download the mobile application through either an application store or similar service
on the mobile phone. The application should be free to download.
RAT: In order for a user to download the mobile applicaiton.
DEP: None

# 3.2.1.2 Funcational Requirement 1.2

ID: FR2
Title:Download and notify users of new releases
DESC: When a new/updated version or release of the software is released, the user should check for those manually.
The download of the new release should be done through the mobile phone in the same way as downloading the mobile application.
RAT: In order for a user to download a new/updated release.
DEP:FR1

# 3.2.1.3 Functional requirement 1.3

ID: FR3
TITLE: User registeration-Mobile Application
DESC: Given that a user has downloaded the mobile applciation, then the user should be able to register through the mobile applcaiton.
The user must provide user-name, password and e-mail address. The user can choose to provide a regularly used phone number.
RAT: In order for a user to register on the mobile application.
DEP: FR1  

# 3.2.1.4 Functional requirement 1.4

ID: FR4
TITLE: User Account Basic Information Collection
DESC: After downloading and regisering their account, the user should be able to enter pertinent information for the account. The user
should provide their first and last name, contact information such as email and/or phone number, and gender.
RAT: In order for a user to establish general account information for contacting purposes.
DEP:FR3

# 3.2.1.5 Functional requirement 1.5

ID: FR5
TITLE: User Outfit Information
DESC: The user will provide quantitative and qualitative information about the tuxedo or gown they desire along with a full body photo for
measuring purposes
RAT: In order for the user to establish their outfit requirements
DEP: FR3