# ------------------------------------
# IoT Hub
# ------------------------------------

include(ExternalProject)

# Read the version.cmake file inside the cmake folder at the root
# of this project. That is the file where versioning information for 
# this project resides
include(version)

# Determine the compiler specific C and CXX compile flags
include(compiler_options)

# Pull in any external dependencies by locating their binaries
include(dependencies)

set(EP_PREFIX ${PROJECT_SOURCE_DIR}/external/${CMAKE_BUILD_TYPE} CACHE PATH "External projects prefix")
set(EP_BINARY ${CMAKE_BINARY_DIR}/${CMAKE_BUILD_TYPE} CACHE PATH "External libraries build")
set(EP_INSTALL ${PROJECT_SOURCE_DIR}/lib/${CMAKE_BUILD_TYPE} CACHE PATH "External libraries")

ExternalProject_Add(
	    qpid_proton
	    PREFIX ${EP_PREFIX}/qpid-proton
	    BINARY_DIR ${EP_BINARY}/qpid-proton
	    INSTALL_DIR ${EP_INSTALL}/qpid-proton
	    GIT_REPOSITORY https://github.com/dcristoloveanu/qpid-proton.git
	    GIT_TAG 0.9-IoTClient
	    CMAKE_GENERATOR ${CMAKE_GENERATOR}
	    CMAKE_ARGS -G ${CMAKE_GENERATOR} -DCMAKE_BUILD_TYPE=${CMAKE_BUILD_TYPE} -DBUILD_JAVA=NO -DSYSINSTALL_BINDINGS=OFF -DCMAKE_INSTALL_PREFIX=${EP_INSTALL}/qpid-proton -DCMAKE_BINARY_DIR=${EP_BINARY}/qpid-proton
	)

# We are expecting the qpid-proton include directories to be in the external directory, along with anyh
# other 3rd party dependent application
set(QPID_PROTON_INCLUDE_DIR ${EP_INSTALL}/qpid-proton/include)

# Various variables needed for tests
set(TESTRUNNER_INC "${CMAKE_CURRENT_SOURCE_DIR}/testtools/testrunnerswitcher/inc")
set(MICROMOCK_INC "${CMAKE_CURRENT_SOURCE_DIR}/testtools/micromock/inc")
set(SAL_INC "${CMAKE_CURRENT_SOURCE_DIR}/testtools/sal/inc")
set(CTEST_INC "${CMAKE_CURRENT_SOURCE_DIR}/testtools/ctest/inc")

set(TEST_INCLUDES ${TESTRUNNER_INC} ${MICROMOCK_INC} ${SAL_INC} ${CTEST_INC})

add_custom_target(core)

add_subdirectory(testtools)
add_subdirectory(common)
add_subdirectory(iothub_client)
add_subdirectory(serializer)
