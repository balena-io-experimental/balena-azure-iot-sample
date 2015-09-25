
add_executable(gballoc_unittests gballoc_unittests.cpp main.c)


target_include_directories(gballoc_unittests PUBLIC ${TEST_INCLUDES})
target_link_libraries (gballoc_unittests ${CMAKE_THREAD_LIBS_INIT} ctest micromock common)
