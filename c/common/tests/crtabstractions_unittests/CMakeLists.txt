
add_executable(crtabstractions_unittests crtabstractions_unittests.cpp main.c)


target_include_directories(crtabstractions_unittests PUBLIC ${TEST_INCLUDES})
target_link_libraries (crtabstractions_unittests ${CMAKE_THREAD_LIBS_INIT} ctest micromock common)
