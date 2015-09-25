
add_executable(base64_unittests base64_unittests.cpp main.c)


target_include_directories(base64_unittests PUBLIC ${TEST_INCLUDES})
target_link_libraries (base64_unittests ${CMAKE_THREAD_LIBS_INIT} ctest micromock common)
