# My Resume Bot

This project is a resume website for Abhit Shukla, showcasing his profile, skills, education, projects, and certifications.

## Table of Contents
- [Installation](#installation)
- [Usage](#usage)
- [Docker Setup](#docker-setup)
- [Contributing](#contributing)
- [License](#license)

## Installation

### Clone the Repository
```bash
git clone https://github.com/Abhi7389/myresumebot.git
cd myresumebot
```

### Install Dependencies
This project does not have any server-side dependencies. All required libraries are included via CDN in the HTML file.

## Usage
Open `index.html` in your web browser to view the resume website.

## Docker Setup

### Build Docker Image
```bash
docker build -t myresumebot .
```

### Run Docker Container
```bash
docker run -d -p 8080:80 myresumebot
```

### Access the Application
Open your web browser and navigate to `http://localhost:8080` to view the resume website.

## Contributing
Contributions are welcome! Please fork the repository and create a pull request with your changes.

## License
This project is licensed under the MIT License.
