pipeline {
agent any
    tools {
        // a bit ugly because there is no `@Symbol` annotation for the DockerTool
        // see the discussion about this in PR 77 and PR 52: 
        // https://github.com/jenkinsci/docker-commons-plugin/pull/77#discussion_r280910822
        // https://github.com/jenkinsci/docker-commons-plugin/pull/52
        'org.jenkinsci.plugins.docker.commons.tools.DockerTool' '18.09'
    }

    parameters {
       string(name: 'PR No.', defaultValue: '', description: '' )
    }

    stages {
        stage ("SCM Checkout") {
            steps {
                checkout([
                    $class: 'GitSCM', 
                    branches: [
                        [
                            name: '*/master'
                        ]
                    ], 
                    extensions: [], 
                    userRemoteConfigs: [
                        [
                            credentialsId: 'github-credentials', 
                            url: 'https://github.com/mzck5y/cars-service'
                        ]
                    ]
                ])
            }
        }

        agent {
            docker { image 'node:14-alpine' }
        }
        
        stage ("Approval Gate") {
            steps {
                sh "docker --help"
                input 'Your approval is need to send to production'
            }
        }

        stage ("build") {
            steps {
                echo "Building the application..."
            }
        }
        
        stage ("db") {
            steps {
                echo "Updating database..."
            }
        }

        stage ("deploy") {
            steps {
                echo "Deploying application..."
            }
        }

        stage ("test") {
            steps {
                echo "Testing the application..."
            }
        }

        stage("post-deploy") {
            steps {
                echo "Running post deplly stages    "
            }
        }
    }
    post {
        always {
            echo "Pipeline finished send notifications or email."
        }
        success {
            echo "Pipeline success."
        }  
        failure {
            echo "Pipeline fail."
        }
    }
}
